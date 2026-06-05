using Soenneker.Tests.HostedUnit;

namespace Soenneker.Slack.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SlackOpenApiClientRunnerTests : HostedUnitTest
{
    public SlackOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
