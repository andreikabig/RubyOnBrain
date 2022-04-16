namespace RubyOnBrain.API.Middlewares
{
    public class CourseMiddleware
    {
        private readonly RequestDelegate next;
        public CourseMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            
            
        }
    }
}
