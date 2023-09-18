using CalculateStudentGrades;


var sophia = Utils.LoadSophia();

var report = new Reporter(sophia);

report.RunFinalGradeReport();
