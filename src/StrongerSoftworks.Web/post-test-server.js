const http = require('http');
const fs = require('fs');
const path = require('path');
const url = require('url');

const PORT = 5234;
const publicDir = path.join(__dirname, '../', '../', 'out');

// Helper function to get the correct content type based on file extension
function getContentType(filePath) {
    const ext = path.extname(filePath).toLowerCase();
    switch (ext) {
        case '.html':
            return 'text/html';
        case '.js':
            return 'application/javascript';
        case '.css':
            return 'text/css';
        case '.avif':
            return 'image/avif';
        case '.png':
            return 'image/png';
        case '.jpg':
        case '.jpeg':
            return 'image/jpeg';
        case '.gif':
            return 'image/gif';
        case '.svg':
            return 'image/svg+xml';
        case '.json':
            return 'application/json';
        case '.woff':
            return 'font/woff';
        case '.woff2':
            return 'font/woff2';
        case '.ttf':
            return 'font/ttf';
        default:
            return 'application/octet-stream';
    }
}

function isTextFile(filePath) {
    const ext = path.extname(filePath).toLowerCase();
    switch (ext) {
        case '.html':
        case '.js':
        case '.css':
        // case '.svg':
        // case '.json':
            return true;
        default:
            return false;
    }
}

// Create the server
http.createServer((req, res) => {
    const parsedUrl = url.parse(req.url);
    let filePath = parsedUrl.pathname === '/' ? '/index.html' : parsedUrl.pathname;
    filePath = path.join(publicDir, filePath);

    // Check if the Gzipped file exists
    fs.access(filePath, fs.constants.F_OK, (err) => {
        if (err) {
            res.writeHead(404, { 'Content-Type': 'text/plain' });
            res.end('404 Not Found');
            return;
        }

        // Set headers for serving gzipped content
        if (isTextFile(filePath)) {
            res.writeHead(200, {
                'Content-Type': getContentType(filePath),
                'Content-Encoding': 'gzip'
            });
        } else {
            res.writeHead(200, {
                'Content-Type': getContentType(filePath),
            });
        }
        // Stream the gzipped file to the response
        const fileStream = fs.createReadStream(filePath);
        fileStream.pipe(res);
    });
}).listen(PORT, () => {
    console.log(`Server running at http://localhost:${PORT}`);
});
