using DocumentComponent.CustomAttribute;

namespace DocumentApp;

[Document("A Software Engineering Trainee")]
class BEZAOTrainee
{
    [Document("This initialises the Bezao Trainee with a full name", Input = "It takes the " +
                                                                             "fullname as string")]
    BEZAOTrainee(string fullname)
    {
        FullName = fullname;
    }


    [Document("This sets and gets  the Trainee's FullName")]
    private string FullName { get; set; }
    
    [Document("This sets and gets the Trainee's Age")]
    public string Age { get; set; }
    
    [Document("This Makes the Trainee quiet when something strange happens", 
        Input = "It takes in an someThingsStrange as an object")]
    internal void SomethingStrangeCode(object someThingStrange)
    {
        
    }
    
    [Document("This Makes the Trainee Code when an idea comes", 
        Input = "It takes in an someThingsStrange as an object", Output = "It returns an object")]
    internal void QuietCode(object someThingStrange)
    {
        
    }

    [Document("A Software Engineering Training Program")]
    class BEZAO
    {
        [Document("This initialises BEZAO with a cohort", 
            Input = "It takes a cohort as string")]
        void BEZAOTrainee(string cohort)
        {
            Cohort = cohort;
        }

        [Document("This sets and gets the BEZAO Cohort")]
        private string Cohort {get; set;}
    }
}

[Document("These are what trainee screams")]
enum Scream
{
    Omo, 
    HeyGod,
    GodAbeg,
    OhShit
}