const fs = require('fs')

module.exports = {
    configureWebpack: config => {
        if (process.env.NODE_ENV !== 'production') {
            config.devServer = {
                https: {
                    key: fs.readFileSync('./localhost-key.pem'),
                    cert: fs.readFileSync('./localhost.pem'),
                },
                public: 'https://localhost:8080/'
            }
        }
    },
    css: {
        loaderOptions: {
            sass: {
                additionalData: `
                    @import "@/scss/_variables.scss";
                    @import "@/scss/_mixins.scss";
                `
            }
        }
    }
}