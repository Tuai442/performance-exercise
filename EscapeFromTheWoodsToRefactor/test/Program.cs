using EscapeFromTheWoods.Database.MongoDB;
using test;

MongoDBWoodRepository repository = new MongoDBWoodRepository("mongodb://localhost:27017");


//WoodMongoDBData wood = new WoodMongoDBData(1, 1, 1, 10, 10);

List<WoodMongoDBData> woods = new List<WoodMongoDBData>();

//woods.Add(wood);
//repository.WriteWoods(woods);
//Console.WriteLine("opgeslaan");