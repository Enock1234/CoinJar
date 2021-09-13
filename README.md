The API uses a singleton class as the data repository. It consists of 3 endpoints with the following urls:

1) POST https://localhost:44331/api/coinjar/coin : This adds the coin to the jar.

example of coin 

{
  "Amount":50,
  "Volume":2.5
}

2) GET https://localhost:44331/api/coinjar/amount : This gets the total amount of coins in the jar.
3) DELETE https://localhost:44331/api/coinjar/reset: This resets the coin jar amount to $0.00

Run the application and use the above endpoints. Postman or similar REST client can be used to call the end points.
