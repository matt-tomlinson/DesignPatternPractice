using DesignPatternPractice.Builder.Builders;

namespace DesignPatternPractice.Builder {
    internal class Builder : DesignPattern {
        public override void Run() {
            base.Run();

            PCBuilder builder;

            Shop shop = new Shop();

            builder = new GamingPCBuilder();
            shop.Build(builder);
            builder.PC.WriteInfo();

            builder = new SteamDeckBuilder();
            shop.Build(builder);
            builder.PC.WriteInfo();
        }
    }
}
