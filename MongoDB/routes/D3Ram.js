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
  const D3Ram = {
    //Unique id now done automatically
    name: req.body.name,
    price: req.body.price
  };
    const D3Ramitem = new D3RamItems({
    name: req.body.name,
    price: req.body.price
  });
  D3Ramitem.save()
  .then(result => {
    console.log(result);
  })
  .catch(err => console.log(err));
    res.status(201).json({
        message: 'Handling POST requests to /DDR 3 RAM',
        createdItem: D3Ramitem
    });
});

router.get('/:D3RamId', (req, res, next) => {
    const id = req.params.D3Ramitem;
    D3Ramitem.findById(id).exec().then(doc => { //then block
        console.log(doc);
        res.status(200).json(doc);
      })
      .catch(err => {
        console.log(err);
        res.status(500).json({error: err});
        });

});

router.patch('/:D3RamId', (req, res, next) => {
        res.status(200).json({
        message: 'Updated D3Ram item!'
    });
});

router.delete('/:D3RamId', (req, res, next) => {
    res.status(200).json({
    message: 'Deleted D3Ram item!'
    });
});


module.exports = router;
