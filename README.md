# Dotnet - DynamoDB

AWS DynamoDB is a serverless, key-value, NoSQL Database that can be used to high performance application at any scale. Dynamodb also offers low latency, In-memory cache and multi-region replications


### Primary Keys in DynamoDB

In DynamoDb you have tables, tables contains items and items contain attributes. Items in dynamodb must have unique primary keys.

There are two types of primary keys in dynamodb, namely;

1. Partition Key - is a hash value that determines the partition(The physical storage internal to DynamoDB) where items in a table would be stored. A partition is a section or a segment on a hard drive that is logically seperated from other segements or sections 
2. Partition Key & Sort Key Combination - Items that have sort keys would be sorted in a partition based on their sort key


### DynamoDB Capacity