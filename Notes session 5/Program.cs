namespace Notes_session_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface
            // A top-level interface, one declared in a namespace but not nested inside another type, can be declared public or internal. 
            //The default is internal. Nested interface declarations, those declared inside another type, can be declared using any access modifier.
            //Interface members without an implementation can't include Private access modifier.
            //Members with a default implementation can include any access modifier.
            //Public access modifier is the default access modifier inside interface.
            //You Can not Create an object from interface but you can create a reference from interface.
            #endregion
            #region Shallow Copy and Deep Copy
            //  Refer to how objects are copied, particularly when those objects contain references to other objects.
            // For pure value types(like int, double, struct), both shallow and deep copy are the same: when you copy them, you copy their values
            //For structs with reference type fields , you might need to manually deep copy the reference type fields, but the struct itself is still
            //copied by value.
            //For reference types (such as classes, arrays, and delegates) behave differently a shallow copy and a deep copy have distinct meanings
            #endregion

        }
    }
}
