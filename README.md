#  Shopping Cart 

## Test for building the checkout business to support different promotions with the given inventory

 1. Each sale of a MacBook Pro comes with a free Raspberry Pi B 
 2. Buy 3 Google Homes for the price of 2 
 3.  Buying more than 3 Alexa Speakers will have a 10% discount on all Alexa speakers 


| SKU | Name | Price | InventoryQty |
|:---:|:----:|:-----:|:------------:|
| 120P90 | Google Home | $49.99 | 10 |
| 43N23P | MacBook Pro | $5,399.99 | 5 |
| A304SD | Alexa Speaker | $109.50 | 10 |
| 234234 | Raspberry Pi B | $30.00 | 2 |

### Example Scenarios: 

* Scanned Items: MacBook Pro, Raspberry Pi B  <br>
   Total: $5,399.99 
* Scanned Items: Google Home, Google Home, Google Home  <br>
   Total: $99.98 
* Scanned Items: Alexa Speaker, Alexa Speaker, Alexa Speaker   <br>
   Total: $295.65 
