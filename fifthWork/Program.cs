using System.Globalization;

   Dictionary<string, List<string>> registeredPeople = new Dictionary<string, List<string>>();

            string CourseAndname;

            while ((CourseAndname = Console.ReadLine()) != "end")
            {
                string[] courseSplitted = CourseAndname.Split(" : ").ToArray();

                string courseName = courseSplitted[0];
                string studentName = courseSplitted[1];

                if (!registeredPeople.ContainsKey(courseName))
                {
                    registeredPeople.Add(courseName, new List<string>() { studentName });
                }
                else
                {
                    registeredPeople[courseName].Add(studentName);
                }
            }

            foreach (var course in registeredPeople.OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count()}");

                foreach (var name in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {name}");
                }
}