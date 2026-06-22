using EnumSample;

var projects = new List<Project>();

//Traditional way:
/*Project project = new Project();

project.Name = "Project1";
project.Description = "";
project.Status = ProjectStatus.New;

projects.Add(project);*/

projects.Add(new Project() { Name = "Project1", Description = "", Status = ProjectStatus.New });
projects.Add(new Project() { Name = "Project2", Description = "", Status = ProjectStatus.InProgress });
projects.Add(new Project() { Name = "Project3", Description = "", Status = ProjectStatus.Done });
projects.Add(new Project() { Name = "Project4", Description = "", Status = ProjectStatus.New });

int progressCount = 0;

foreach (var project in projects)
{
    if (project.Status == ProjectStatus.InProgress)
    {
        progressCount++;
    }

    //comparing with internal value assigned to the enum
    int value = (int)project.Status;
    if (value == 20)
    {
        progressCount++;
    }
}

Console.WriteLine(progressCount);
