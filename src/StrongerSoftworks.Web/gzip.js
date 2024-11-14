
const fs = require('fs/promises');
const path = require('path');
const zlib = require('zlib');

// Set the directory to compress
const targetDirectory = path.join(__dirname, '../', '../', 'out'); // Change this to your target directory

// Function to compress a file
async function compressFile(filePath) {
  const source = await fs.readFile(filePath);
  const compressed = zlib.gzipSync(source);

  const compressedPath = `${filePath}`;
  await fs.writeFile(compressedPath, compressed);
  // await fs.unlink(filePath); // Delete original file
  console.log(`Compressed: ${filePath}`);
}

// Function to recursively get all files with specified extensions
async function getFiles(dir) {
  let files = await fs.readdir(dir, { withFileTypes: true });
  let fileList = [];

  for (let file of files) {
    const res = path.resolve(dir, file.name);
    if (file.isDirectory()) {
      fileList = fileList.concat(await getFiles(res));
    } else if (/\.(js|css|html)$/.test(file.name)) {
      fileList.push(res);
    }
  }

  return fileList;
}

// Main function to compress all target files in a directory
async function compressFilesInDirectory(directory) {
  try {
    const files = await getFiles(directory);
    await Promise.all(files.map(file => compressFile(file)));
    console.log('All files compressed and original files deleted.');
  } catch (error) {
    console.error('Error compressing files:', error);
  }
}

// Run the script
compressFilesInDirectory(targetDirectory);
