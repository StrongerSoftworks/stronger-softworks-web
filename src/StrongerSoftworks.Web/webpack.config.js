const path = require('path');
const glob = require('glob');
const MiniCssExtractPlugin = require('mini-css-extract-plugin');
const TerserPlugin = require('terser-webpack-plugin');
const CssMinimizerPlugin = require('css-minimizer-webpack-plugin');
const HtmlWebpackPlugin = require('html-webpack-plugin')

const isDebugMode = process.env.buildMode === 'Debug';

console.log(`isDebugMode: ${isDebugMode}`);

module.exports = [
    {
        mode: isDebugMode ? 'development' : 'production',
        entry: {
            bootstrap: 'bootstrap',
        },
        output: {
            filename: 'bootstrap.js',
            path: path.resolve(__dirname, 'wwwroot/bundle'),
            publicPath: '/',
            library: '[name]',
            libraryTarget: 'var'
        },
        optimization: {
            splitChunks: {
                chunks: 'all',
            },
            minimize: !isDebugMode,
            minimizer: !isDebugMode ? [
                new TerserPlugin({
                    terserOptions: {
                        compress: !isDebugMode,
                        mangle: !isDebugMode,
                    },
                })
            ] : [],
        },
        plugins: [
            new HtmlWebpackPlugin({
                inject: false,
                template: './WebpackTemplates/VendorScripts.ejs',
                filename: path.join(__dirname, "./Components/Webpack/VendorScripts.razor"),
                hash: true,
                minify: !isDebugMode,
                templateParameters: (compilation, assets) => {
                    const scripts = assets.js.map((filePath) => `<script src="/bundle${filePath}"></script>`).join("\n");
                    return { scripts };
                },
            }),
        ],
        devtool: isDebugMode ? 'source-map' : false,
    },
    {
        mode: isDebugMode ? 'development' : 'production',
        entry: {
            styles: './Styles/app.scss',
        },
        output: {
            filename: '[name].js',
            path: path.resolve(__dirname, 'wwwroot/bundle'),
            publicPath: '/',
        },
        resolve: {
            extensions: ['.js', '.scss'],
            preferRelative: true,
        },
        module: {
            rules: [
                {
                    test: /\.js$/,
                    exclude: /node_modules/,
                    use: {
                        loader: 'babel-loader',
                        options: {
                            presets: ['@babel/preset-env'],
                        },
                    },
                },
                {
                    test: /\.scss$/,
                    use: [
                        MiniCssExtractPlugin.loader,
                        'css-loader',
                        'sass-loader',
                    ],
                },
                {
                    test: /\.(woff|woff2|eot|ttf|otf)$/i,
                    type: "asset/inline",
                },
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
                    const styleSheets = assets.css.map((filePath) => `<link rel="stylesheet" href="/bundle${filePath}" />`).join("\n");
                    return { styleSheets };
                },
            }),
            new HtmlWebpackPlugin({
                inject: false,
                template: './WebpackTemplates/Scripts.ejs',
                filename: path.join(__dirname, "./Components/Webpack/Scripts.razor"),
                hash: true,
                minify: !isDebugMode,
                templateParameters: (compilation, assets) => {
                    const scripts = assets.js.map((filePath) => `<script src="/bundle${filePath}"></script>`).join("\n");
                    return { scripts };
                },
            }),
            new MiniCssExtractPlugin({
                filename: '[name].css',
            })
        ],
        optimization: {
            splitChunks: {
                chunks: 'all',
            },
            minimize: !isDebugMode,
            minimizer: !isDebugMode ? [
                new TerserPlugin({
                    terserOptions: {
                        compress: !isDebugMode,
                        mangle: !isDebugMode,
                    },
                }),
                new CssMinimizerPlugin(),
            ] : [],
        },
        devtool: isDebugMode ? 'source-map' : false,
    }
];
