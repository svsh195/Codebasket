namespace Dices.Startup;

public static class MapEndpoints
{
    public static WebApplication MapDiceEndpoints(this WebApplication app)
    {
        app.MapGet("/d20", () => Dice.Roll(20));
        app.MapGet("/d20/{modifier}", (int modifier) => Dice.Roll(20, modifier));

        app.MapGet("/d12", () => Dice.Roll(12));
        app.MapGet("/d12/{modifier}", (int modifier) => Dice.Roll(12, modifier));

        app.MapGet("/d10", () => Dice.Roll(10));
        app.MapGet("/d10/{modifier}", (int modifier) => Dice.Roll(10, modifier));

        app.MapGet("/d8", () => Dice.Roll(8));
        app.MapGet("/d8/{modifier}", (int modifier) => Dice.Roll(8, modifier));

        app.MapGet("/d6", () => Dice.Roll(6));
        app.MapGet("/d6/{modifier}", (int modifier) => Dice.Roll(6, modifier));

        app.MapGet("/d4", () => Dice.Roll(4));
        app.MapGet("/d4/{modifier}", (int modifier) => Dice.Roll(4, modifier));

        app.MapGet("/d100", () => Dice.Roll(10, multiplier: 10));
        //app.MapGet("/d100/{modifier}", (int modifier) => Dice.Roll(4, modifier, multiplier: 10));

        return app;
    }
}