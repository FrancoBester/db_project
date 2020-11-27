const mongoose = require('mongoose');

const Schema = new mongoose.Schema;

var CrawlerSchema = new mongoose.Schema(
    {
        _id: mongoose.Schema.Types.ObjectId,
        name: { type: String, required: true },
        description: { type: String, required: true },
        InventoryValue: { type: String, required: true },
        PartType: { type: String, required: true },
        url: { type: String, required: true }
    });

module.exports = mongoose.model('RawProduct', CrawlerSchema);
