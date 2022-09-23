# Installing/using MongoDB
Having used MongoDB on a personal project previously I had no issues installing MongoDB on my current laptop. 
I validated the installation package as requested:
- sceenshot of validation here

I did not encounter any issues with using the MongoDB shell either.

# Experiment 1 results
Below you will find screenshots from the different CRUD operations.
### CRUD insert
### CRUD query
### CRUD update
### CRUD delete
### CRUD bulkwrite

# Experiment 2
### Map-reduce example

### Custom Map-reduce
My custom map reduce function works on the same "orders" collection as the map-reduce example. Its purpose is to list all of the items that has been bought, grouped by who bought them. I could have combined them on sku, making for example one element for 'oranges' instead of having it occuring multiple times in a single customer, but with the current setup you can also see the amount of different times a person has bought an item. In retrospect a more elegant way of doing this would be to combine them and keep a counter for how many different times the item has been bought but I did not implement this here. 
- screenshot of custom map reduce

# Pending issues
I have no pending issues with this assignment, but if I were to do it over I would probably change my custom map reduce function to be a bit more elegant.