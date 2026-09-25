namespace LeetTracker.Api.Controllers;

public class ProblemController : ControllerBase
{
    private readonly ProblemRepository _problemRepository;

    public ProblemController(ProblemRepository problemRepository)
    {
        _problemRepository = problemRepository;
    }
}