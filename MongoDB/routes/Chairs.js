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
  const Chair = {
    //Unique id now done automatically
    name: req.body.name,
    price: req.body.price
  };
    const Chairitem = new ChairItems({
    name: req.body.name,
    price: req.body.price
  });
    ChairItems.save()
  .then(result => {
    console.log(result);
  })
  .catch(err => console.log(err));
    res.status(201).json({
        message: 'Handling POST requests to /Crawler',
        createdItem: ChairItems
    });
});

router.get('/:ChairId', (req, res, next) => {
    const id = req.params.ChairItems;
    ChairItems.findById(id).exec().then(doc => { //then block
        console.log(doc);
        res.status(200).json(doc);
      })
      .catch(err => {
        console.log(err);
        res.status(500).json({error: err});
        });

});

router.patch('/:ChairId', (req, res, next) => {
        res.status(200).json({
        message: 'Updated Chair item!'
    });
});

router.delete('/:ChairId', (req, res, next) => {
    res.status(200).json({
    message: 'Deleted Chair item!'
    });
});


module.exports = router;
