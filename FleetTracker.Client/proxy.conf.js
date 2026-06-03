module.exports = {
  "/api": {
    target: process.env.services__api__https__0 || process.env.services__api__http__0 || "https://localhost:7240",
    secure: false,
    changeOrigin: true
  }
};
