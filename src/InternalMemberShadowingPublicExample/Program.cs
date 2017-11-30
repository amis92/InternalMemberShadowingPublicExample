using Library;

namespace InternalMemberShadowingPublicExample
{
    class Program
    {
        /// <summary>
        /// <see cref="Class1.Member()"/>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            new Class1().Member();
        }
    }
}
