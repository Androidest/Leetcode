public class Solution {
    class Course
    {
        public bool IsVisited = false;
        public bool HasMyBody = false;
        public List<int> PreCourses = new List<int>();
    }

    Course[] Courses;
    
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Courses = new Course[numCourses];

        // init graph
        for (int i = 0; i < numCourses; ++i)
            Courses[i] = new Course();
        for (int i = 0; i < prerequisites.Length; ++i)
        {
            int corseIndex = prerequisites[i][0];
            int preCorseIndex = prerequisites[i][1];
            Courses[corseIndex].PreCourses.Add(preCorseIndex);
        }

        // find loop in graph with a snake body
        for (int i = 0; i < numCourses; ++i)
            if (CheckLoopRecursively(i))
                return false;
        return true;
    }

    bool CheckLoopRecursively(int index)
    {
        Course cur = Courses[index];
        if (cur.IsVisited) // when this is visited then return 
            return cur.HasMyBody; // return true if there is my body (has loop), else return false

        cur.IsVisited = true;
        cur.HasMyBody = true;
        foreach (int preIndex in cur.PreCourses)
            if (CheckLoopRecursively(preIndex))
                return true;
        cur.HasMyBody = false;
        return false;
    }
}