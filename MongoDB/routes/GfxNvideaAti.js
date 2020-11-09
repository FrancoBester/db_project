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
  const CPUProcessor = {
    //Unique id now done automatically
    name: req.body.name,
    price: req.body.price
  };
    const CPUProcessoritem = new CPUProcessorItems({
    name: req.body.name,
    price: req.body.price
  });
  Crawleritem.save()
  .then(result => {
    console.log(result);
  })
  .catch(err => console.log(err));
    res.status(201).json({
        message: 'Handling POST requests to /Crawler',
        createdItem: Crawleritem
    });
});

router.get('/:CPUId', (req, res, next) => {
    const id = req.params.CPUId;
    CPUId.findById(id).exec().then(doc => { //then block
        console.log(doc);
        res.status(200).json(doc);
      })
      .catch(err => {
        console.log(err);
        res.status(500).json({error: err});
        });

});

router.patch('/:CPUId', (req, res, next) => {
        res.status(200).json({
        message: 'Updated CPU item!'
    });
});

router.delete('/:CPUId', (req, res, next) => {
    res.status(200).json({
    message: 'Deleted CPU item!'
    });
});


module.exports = router;
