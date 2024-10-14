const path = require('path');
const glob = require('glob');
const HtmlWebpackPlugin = require('html-webpack-plugin');
const MiniCssExtractPlugin = require('mini-css-extract-plugin');
const { PurgeCSSPlugin } = require('purgecss-webpack-plugin');
const ImageMinimizerPlugin = require('image-minimizer-webpack-plugin');
const CopyPlugin = require('copy-webpack-plugin');
//const ExtractCSSChunksPlugin = require('extract-css-chunks-webpack-plugin');

const isDebugMode = process.env.buildMode === 'Debug';

console.log(`isDebugMode: ${isDebugMode}`);

module.exports = [
    {
        mode: isDebugMode ? 'development' : 'production',
        entry: {
            bootstrap: './wwwroot/js/bootstrap.js',
            GLightbox: 'glightbox',
        },
        output: {
            filename: '[name].js',
            path: path.resolve(__dirname, 'wwwroot/bundle/vendor/js'),
            publicPath: '/',
            library: '[name]',
            libraryTarget: 'var'
        },
        plugins: [
            new HtmlWebpackPlugin({
                inject: false,
                template: './WebpackTemplates/VendorScripts.ejs',
                filename: path.join(__dirname, "./Components/Webpack/VendorScripts.razor"),
                hash: true,
                minify: !isDebugMode,
                templateParameters: (compilation, assets) => {
                    const scripts = assets.js.map((filePath) => `<script src="/bundle/vendor/js${filePath}"></script>`).join("\n");
                    return { scripts };
                },
            }),
        ],
        devtool: isDebugMode ? 'source-map' : false,
    },
    {
        mode: isDebugMode ? 'development' : 'production',
        entry: {
            app: './wwwroot/js/main.js',
        },
        output: {
            path: path.resolve(__dirname, 'wwwroot/bundle/js'),
            publicPath: '/',
        },
        resolve: {
            extensions: ['.js'],
            preferRelative: true,
        },
        module: {
            rules: [

            ],
        },
        plugins: [
            new HtmlWebpackPlugin({
                inject: false,
                template: './WebpackTemplates/Scripts.ejs',
                filename: path.join(__dirname, "./Components/Webpack/Scripts.razor"),
                hash: true,
                minify: !isDebugMode,
                templateParameters: (compilation, assets) => {
                    const scripts = assets.js.map((filePath) => `<script src="/bundle/js${filePath}"></script>`).join("\n");
                    return { scripts };
                },
            }),
        ],
        devtool: isDebugMode ? 'source-map' : false,
    },
    {
        mode: isDebugMode ? 'development' : 'production',
        entry: {
            theme: './wwwroot/scss/theme.scss',
            bootstrap: './wwwroot/scss/bootstrap.scss',
            fonts: './wwwroot/scss/fonts.scss',
        },
        output: {
            path: path.resolve(__dirname, 'wwwroot/bundle/css'),
            publicPath: '/',
        },
        resolve: {
            extensions: ['.scss'],
            preferRelative: true,
        },
        module: {
            rules: [
                {
                    test: /\.s?css$/,
                    use: [
                        MiniCssExtractPlugin.loader,
                        {
                            loader: 'css-loader',
                            options: {
                                sourceMap: true,
                                esModule: false,
                            }
                        },
                        {
                            loader: 'sass-loader',
                            options: {
                                sourceMap: true,
                            }
                        },

                    ]
                },
                {
                    test: /\.(woff|woff2|eot|ttf|otf)$/i,
                    use: [{
                        loader: 'file-loader',
                        options: {
                            publicPath: '../fonts',
                            outputPath: '../fonts',
                            name: '[name].[ext]',
                            //esModule: false
                        }
                    }],
                },
                {
                    test: /\.(png|jpe?g|webp|gif|svg)$/,
                    use: [{
                        loader: 'file-loader',
                        options: {
                            publicPath: '../img',
                            outputPath: '../img',
                            name: '[name].[ext]',
                            //esModule: false
                        }
                    }],
                }
            ],
        },
        plugins: [
            new HtmlWebpackPlugin({
                inject: false,
                template: './WebpackTemplates/StyleSheets.ejs',
                filename: path.join(__dirname, "./Components/Webpack/StylesSheets.razor"),
                hash: true,
                minify: !isDebugMode,
                templateParameters: (compilation, assets) => {
                    const styleSheets = assets.css.map((filePath) => `<link rel="stylesheet" href="/bundle/css${filePath}" />`).join("\n");
                    return { styleSheets };
                },
            }),
            new MiniCssExtractPlugin({
                filename: "[name].css",
                chunkFilename: "[id].css",
            }),
            new PurgeCSSPlugin({
                paths: glob.sync(`${path.join(__dirname, '../')}/**/*.{razor,cs,js}`, { ignore: ['**/node_modules/**'], noDir: true }),
                skippedContentGlobs: ['node_modules']
            }),
            new CopyPlugin(
            {
                patterns: [
                    {
                        from: "wwwroot/img/**/*",
                        to({ context, absoluteFilename }) {
                            return `../img/${path.relative(path.join(context, 'wwwroot', 'img'), absoluteFilename)}`;
                        }
                    },
                ],
            }),
            //new ExtractCSSChunksPlugin({
            //    filename: 'wwwroot/bundle/css/[name].css',
            //    chunkFilename: 'wwwroot/bundle/css/[id].css',
            //}),
        ],
        optimization: {
            minimizer: [
                new ImageMinimizerPlugin({
                    include: /\.\/\.(jpe?g|png|gif|svg)$/i,
                    loader: true,
                    minimizer: {
                        implementation: ImageMinimizerPlugin.sharpMinify,
                        options: {
                            encodeOptions: {
                                jpeg: {
                                    // https://sharp.pixelplumbing.com/api-output#jpeg
                                    quality: 100,
                                },
                                webp: {
                                    // https://sharp.pixelplumbing.com/api-output#webp
                                    lossless: true,
                                },
                                avif: {
                                    // https://sharp.pixelplumbing.com/api-output#avif
                                    lossless: true,
                                },

                                // png by default sets the quality to 100%, which is same as lossless
                                // https://sharp.pixelplumbing.com/api-output#png
                                png: {},

                                // gif does not support lossless compression at all
                                // https://sharp.pixelplumbing.com/api-output#gif
                                gif: {},
                            },
                        },
                    },
                }),
            ]
        },
        devtool: isDebugMode ? 'source-map' : false,
    }
];
