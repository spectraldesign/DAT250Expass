# Installing/using MongoDB
Having used MongoDB on a personal project previously I had no issues installing MongoDB on my current laptop. 
I validated the installation package as requested:
![verify](https://user-images.githubusercontent.com/59234024/191962090-ff0ab2c3-116f-45f8-83a6-7b3ca443804d.png)


I did not encounter any issues with using the MongoDB shell either.

# Experiment 1 results
Below you will find screenshots from the different CRUD operations.
### CRUD insert
![CRUD insert](https://user-images.githubusercontent.com/59234024/191962128-3fe491e8-9b7b-4761-8b45-fdaaccc031cd.png)
### CRUD query
![CRUD query](https://user-images.githubusercontent.com/59234024/191962162-3f89fe92-717d-4cc2-b266-c115684b0867.png)
### CRUD update
![CRUD update](https://user-images.githubusercontent.com/59234024/191962181-895e8747-032d-4059-ae4f-2848419fdfe7.png)
### CRUD delete
![CRUD delete](https://user-images.githubusercontent.com/59234024/191962216-b6883362-7d8c-4f92-8c4d-bbdbd2d203ca.png)
### CRUD bulkwrite
![CRUD bulkwrite](https://user-images.githubusercontent.com/59234024/191962231-694a5747-ea74-4850-ac19-c38652c00df9.png)

# Experiment 2
### Map-reduce example
![map reduce example](https://user-images.githubusercontent.com/59234024/191962254-e44f3a72-ffe6-4276-8358-f510616421b4.png)

### Custom Map-reduce
My custom map reduce function works on the same "orders" collection as the map-reduce example. Its purpose is to list all of the items that has been bought, grouped by who bought them. I could have combined them on sku, making for example one element for 'oranges' instead of having it occuring multiple times in a single customer, but with the current setup you can also see the amount of different times a person has bought an item. In retrospect a more elegant way of doing this would be to combine them and keep a counter for how many different times the item has been bought but I did not implement this here. 
![custom mapReducc](https://user-images.githubusercontent.com/59234024/191962395-29a1eb30-c7d3-48af-bdcc-419419edcffb.png)


# Pending issues
I have no pending issues with this assignment, but if I were to do it over I would probably change my custom map reduce function to be a bit more elegant.
