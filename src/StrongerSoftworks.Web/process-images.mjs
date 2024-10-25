import sharp from 'sharp'
import fs from 'fs'

const sizes = [720, 480, 240];

function processImagesInDir(dir) {
    const fileList = fs.readdirSync(dir);
    for (const file of fileList) {
        const name = `${dir}/${file}`;
        if (fs.statSync(name).isDirectory()) {
            processImagesInDir(name);
        } else {
            const newDir = `${dir}`.replace('assets', 'wwwroot/bundle');
            const newFile = file.slice(0, file.lastIndexOf("."));
            if (!fs.existsSync(newDir)) {
                fs.mkdirSync(newDir);
            }

            // keep original SVGs
            if (file.endsWith('.svg')) {
                fs.copyFile(name, `${newDir}/${file}`, (err) => {
                    if (err) {
                        console.log(err);
                    }
                });
            }

            // PNG
            sharp(name)
                .png({
                    quality: 90,
                    compressionLevel: 5,
                    effort: 3,
                })
                .toFile(`${newDir}/${newFile}.png`, (err) => {
                    if (err) {
                        console.error(err);
                    }
                });

            // AVIF
            sharp(name)
                .avif({
                    quality: 70,
                    lossless: false,
                    speed: 5,
                    effort: 3,
                })
                .toFile(`${newDir}/${newFile}.avif`, (err) => {
                    if (err) {
                        console.error(err);
                    } else {
                        const resize = size => sharp(`${newDir}/${newFile}.avif`)
                            .resize(size, size, { fit: 'inside' })
                            .toFile(`${newDir}/${newFile}-${size}.avif`);

                        Promise
                            .all(sizes.map(resize));
                    }
                });
        }
    }
}

console.log('Processing images')

if (!fs.existsSync('wwwroot/bundle')) {
    fs.mkdirSync('wwwroot/bundle');
}
processImagesInDir('assets/img');
