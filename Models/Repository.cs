using System;
using System.Collections.Generic;
using School.Models;

namespace School.Models {
    public static class Repository {
        private static List<StudentCheck> responses = new List<StudentCheck>();
        public static IEnumerable<StudentCheck> Responses => responses;
        public static void AddResponse(StudentCheck response) {
            responses.Add(response);
        }
    }
}