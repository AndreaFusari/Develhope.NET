//Create a class with private, protected, internal, and public access modifiers.
//In a separate class, try accessing these members and observe the compilation errors, if any.
//Fix the errors by modifying the access modifiers or using proper access techniques.

using Esercizio7;

Class1 class1 = new Class1();

class1.Property1 = 1; // proprietà "public" accessibile dappertutto

//property2 "protecded" accessibile all'interno della classe in cui è contenuta o dalle classi che la estendono

class1.SetProperty3(7); // proprietà "private" accessibile solamente dalla classe in cui è contenuta o tramite metodi getter e setter
