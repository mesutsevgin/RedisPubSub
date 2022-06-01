# REDIS PUB/SUB

Run Docker Container

```
docker run --name my-redis -p 6379:6379 -d redis
```

Subscriber
```
cd RedisSubscriber && dotnet run
```

Publisher
```
cd RedisPublisher && dotnet run
```