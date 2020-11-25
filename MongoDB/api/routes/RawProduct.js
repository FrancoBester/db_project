const express = require('express');
const router = express.Router();
const mongoose = require('mongoose');

const CrawlerItems = require('../models/CrawlerSchema');
var Schema = new mongoose.Schema;
/*router.get('/', (req, res, next) => {
    res.status(200).json({
        message: 'Handling GET requests to /Crawler'
    });
});*/


router.get("/", (req, res, next) => {
    CrawlerItems.find()
        .exec()
        .then(docs => {
            console.log(docs);
            //   if (docs.length >= 0) {
            res.status(200).json(docs);
            //   } else {
            //       res.status(404).json({
            //           message: 'No entries found'
            //       });
            //   }
        })
        .catch(err => {
            console.log(err);
            res.status(500).json({
                error: err
            });
        });
});



router.post('/', (req, res, next) => {
    const RawProduct = new CrawlerItems({
        //Unique id now done automatically
        name: req.body.name,
        productName: req.body.productName,
        description: req.body.description,
        InventoryValue: req.body.InventoryValue,
        PartType: req.body.PartType
    });
    RawProduct
        .save()
        .then(result => {
            console.log(result);
            res.status(201).json({
                message: 'Handling POST requests to /Crawler',
                createdProduct: result
            });
        })
        .catch(err => {
            console.log(err);
            res.status(500).json({
                error: err
            });
        });
});

router.get('/:rawProductId', (req, res, next) => {
    const id = req.params.CrawlerId;
    CrawlerItems.findById(id)
        .exec()
        .then(doc => { //then block
            console.log("From database", doc);
            if (doc) {
                res.status(200).json(doc);
            } else {
                res.status(404)
                    .json({ message: "No valid entry found for provided ID" });
            }

        })
        .catch(err => {
            console.log(err);
            res.status(500).json({ error: err });
        });
});

router.patch('/:rawProductId', (req, res, next) => {
    res.status(200).json({
        message: 'Updated Product item!'
    });
});

router.delete('/:rawProductId', (req, res, next) => {
    res.status(200).json({
        message: 'Deleted Product item!'
    });
});


module.exports = router;
