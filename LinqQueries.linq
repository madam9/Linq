<Query Kind="Statements">
  <Connection>
    <ID>57dd2157-e5c0-438d-abfd-ef96860c50ef</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//Waiters
/*var results = from x in Waiters
where x.FirstName.Contains("a")
orderby x.LastName
select x.LastName + ", "+ x.FirstName;
results.Dump();*/
from x in Items
where x.CurrentPrice > 5.00m
select new{
		x.Description,
		x.Calories
}