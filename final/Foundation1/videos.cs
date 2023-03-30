class videos
{
  public string tittle { get; set; }
  public string author { get; set; }
  public int length { get; set; }

  public string GetVideoDetails()
  {
    return $"The tittle: {tittle}\n The author is: {author}\n The length of the video: {length}";
  }
  List<string> comment = new List<string>()
  {
    "I enjoyed watching your video",
    "Your video was amazing",
    "Bravo!! the video had a nice ending",
  };
}