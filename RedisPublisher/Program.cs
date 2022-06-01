// See https://aka.ms/new-console-template for more information

using StackExchange.Redis;

const string redisConnectionString = "localhost:6379";
ConnectionMultiplexer connection = ConnectionMultiplexer.Connect(redisConnectionString);

const string channel = "test-channel";
var pubSub = connection.GetSubscriber();
pubSub.PublishAsync(channel, "This is a test message!! Mesut", CommandFlags.FireAndForget);

Console.Write("Message Successfully sent to test-channel");
Console.ReadLine();