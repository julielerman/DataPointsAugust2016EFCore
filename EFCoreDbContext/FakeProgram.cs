using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDbContext
{ //this is here because the tools PREVIEW does not currently support class libraries in .net standard
  //REF: https://docs.efproject.net/en/latest/cli/dotnet.html#targeting-class-library-projects-is-not-supported
  //it also required that I modify the project.json here and then the project.json in the test project which depends on this project

  public class FakeProgram
    {
    public static void Main(string[] args) {
    }
  
}
}
