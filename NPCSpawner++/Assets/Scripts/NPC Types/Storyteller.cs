namespace Pattern.FactoryMethod
{
    public class Storyteller : INPC
    {
        public void Speak()
        {
            UIManager.DisplayStorytellerMessage("Storyteller: “Gather ‘round, gather ‘round! Have you heard of the man who haunts the woods at dusk? " +
                "They say he appears only when the light fades from the sky, his coat heavy with herbs that smell of earth and rot. " +
                "He collects only the strange ones—the plants that glow faintly and he whispers to them as though they’re alive. " +
                "And those herbs? They’re not for tea—oh no. Some bring dreams you can’t escape, and others... they say, show you your untimely death. " +
                "So, if you hear a whisper in the woods? Pray it’s only the wind.”");
            ImageManager.DisplayStorytellerImage();
        }
    }
}