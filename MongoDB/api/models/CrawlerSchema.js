const mongoose = require('mongoose');

const Schema = new mongoose.Schema;

const CrawlerSchema = new mongoose.Schema(
    { name: String },
    { productName: String },
    { description: String },
    { InventoryValue: String },
    { PartType: String }, { _id: true, autoIndex: true });

module.exports = mongoose.model('RawProduct', CrawlerSchema);
