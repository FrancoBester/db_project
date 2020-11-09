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

router.post('/', (req, res, next) => {
  const RawProduct = {
    //Unique id now done automatically
    name: req.body.name,
    productName: req.body.productName,
    description: req.body.description,
    InventoryValue: req.body.InventoryValue,
    PartType: req.body.PartType
  };
    const RawProductitem = new RawProductitem({
        name: req.body.name,
        productName: req.body.productName,
        description: req.body.description,
        InventoryValue: req.body.InventoryValue,
        PartType: req.body.PartType
  });
    RawProductitem.save()
  .then(result => {
    console.log(result);
  })
  .catch(err => console.log(err));
    res.status(201).json({
        message: 'Handling POST requests to /Crawler',
        createdItem: RawProductitem
    });
});

router.get('/:rawProductId', (req, res, next) => {
    const id = req.params.CrawlerId;
    CrawlerItems.findById(id).exec().then(doc => { //then block
        console.log(doc);
        res.status(200).json(doc);
      })
      .catch(err => {
        console.log(err);
        res.status(500).json({error: err});
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
