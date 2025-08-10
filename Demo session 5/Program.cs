namespace Demo_session_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface 
            //IType refType;
            //// Declare Reference From Type "IType"
            //// This Reference Can Refer To An Object From Any Type That Implement Interface "IType"
            //// CLR Will Allocate 4 Uninitialized Bytes At Stack 

            ////refType = new IType(); // Invalid 

            //refType = new Type();
            //refType.MyProperty = 10;
            //refType.MyMethod(); // Hello From Type
            //refType.Print(); // Default Implemented Method


            //Type typeObj = new Type();
            //typeObj.MyProperty = 10;
            //typeObj.MyMethod(); // Hello From Type
            //					//typeObj.Print(); // Invalid 
            #endregion
            #region Interface Example 01
            //TypeA typeA = new TypeA();
            //PrintFiveNumbersFromSeries(typeA); // 0 2 4 6 8

            //Console.WriteLine("======================");

            //TypeB typeB = new TypeB();
            //PrintFiveNumbersFromSeries(typeB); // 0 3 6 9 12 

            //TypeC typeC = new TypeC();
            //PrintFiveNumbersFromSeries(typeC); // Invalid [Class Doesn't Implement Interface]

            #endregion
            #region Interface Example 02

            //Car carObj = new Car();
            //carObj.Speed = 120;
            //carObj.Backward(); // Move Car Backward
            //carObj.Forward();  // Move Car Forward
            //carObj.Left();     // Move Car Left
            //carObj.Right();    // Move Car Right


            //Airplane airplaneObj = new Airplane();
            ////airplaneObj.Backward(); // Invalid
            //airplaneObj.Forward();  // Airplane Move Forward
            ////airplaneObj.Left();    // Invalid
            ////airplaneObj.Right();    // Invalid


            //IMoveOnAir moveAirplaneOnAir = new Airplane();
            //moveAirplaneOnAir.Backward(); // Airplane Move Backward on Air
            //moveAirplaneOnAir.Forward();  // Airplane Move Forward
            //moveAirplaneOnAir.Left();     // NotImplementedException
            //moveAirplaneOnAir.Right();    // NotImplementedException


            //IMoveOnGround moveAirplaneOnGround = new Airplane();
            //moveAirplaneOnGround.Backward(); // Airplane Move Backward on Ground
            //moveAirplaneOnGround.Forward();  // Airplane Move Forward
            //moveAirplaneOnGround.Left();     // NotImplementedException
            //moveAirplaneOnGround.Right();    // NotImplementedException

            #endregion
        }
    }
}
