using DesignPatterns.Structural.Decorators;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Structural.Decorator
{
    public class NotifierTests
    {
        [Fact]
        public void NotifierDecoratorShouldCallChildrenRecursive()
        {
            var decorator =
                new SmsNotifierDecorator(
                    new FacebookNotifierDecorator(
                        new SlackNotifierDecorator(
                            new Notifier())));

            var message = decorator.Send("Hello world!", 1);

            var expectedMessage = "- Broadcasting message through SMS:\n" +
                                       "-- Broadcasting message through Facebook:\n" +
                                       "--- Broadcasting message through Slack:\n" +
                                       "---- Broadcasting message: Hello world!";

            Assert.Equal(expectedMessage, message);
        }
    }
}