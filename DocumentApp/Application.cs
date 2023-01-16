using DocumentComponent;

namespace DocumentApp;

public static class Application
{
    public static void GetStarted()
    {
        Validation getDescription = new Validation("description", "input", "output");
        getDescription.GetDocs();
    }
}