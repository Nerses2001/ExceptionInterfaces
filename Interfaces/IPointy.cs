// An interface is nothing more than a named set of abstract members.
// Interfaces  contain only member definitions.
namespace ExceptionInterfaces.Interfaces
{
    public   interface  IPointy
    {
        byte GetNumberOfPoints();
        // A read-write property in an interface would look like:
        // retType PropName { get; set; }
        //
        // while a write-only property in an interface would be:
        // retType PropName { set; }
        byte Points { get; }

    }
}
