const express = require('express');
const router = express.Router();
const mongoose = require('mongoose');

const CrawlerItems = require('../models/CrawlerSchema');
var Schema = new mongoose.Schema;

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
            //   }      //TO TEST IF EMPTY, not needed
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
        _id: new mongoose.Types.ObjectId(),
        name: req.body.name,
        description: req.body.description,
        InventoryValue: req.body.InventoryValue,
        PartType: req.body.PartType,
        url: req.body.url
    });
    RawProduct
        .save()
        .then(result => {
            console.log(result);
            res.status(201).json({
                message: 'Handling POST requests to /RawProduct',
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

router.get('/:RawProductId', (req, res, next) => {
    const id = req.params.RawProductId;
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

router.patch('/:RawProductId', (req, res, next) => {
    const id = req.params.RawProductId;
    //const updateOps = {};
    //for (const ops of req.body) {
    //    updateOps[ops.propName] = ops.value;
    //} // old way
    CrawlerItems.update({ _id: id }, { $set: req.body })
        .exec()
        .then(result => {
            console.log(result);
            res.status(200).json(result);
        })
        .catch(err => {
            console.log(err);
            res.status(500).json({
                error: err
            });
        });
});

router.delete('/:RawProductId', (req, res, next) => {
    const id = req.params.RawProductId
    CrawlerItems.deleteMany({ _id: id })
        .exec()
        .then(result => {
            res.status(200).json(result);
        })
        .catch(err => {
            console.log(err);
            res.status(500).json({
                error: err
            });
        });
});


module.exports = router;
