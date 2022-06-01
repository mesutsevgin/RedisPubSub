using StackExchange.Redis;

const string redisConnectionString = "localhost:6379";
var connection = ConnectionMultiplexer.Connect(redisConnectionString);
const string channel = "test-channel";
Console.WriteLine("Listening test-channel");
var pubSub = connection.GetSubscriber();
pubSub.Subscribe(channel, (redisChannel, message) => Console.Write("Message received from test-channel : " + message));
Console.ReadLine();