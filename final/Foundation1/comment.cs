class comment
{
  public string name { get; set; }
  public string name1 { get; set; }
  public string name2 { get; set; }
  public string GetCommentors()
  {
    return $"{name}: I enjoyed watching your video.\n{name1}: Your video was amazing!!\n {name2}: Bravo!! the video had a nice ending";
  }
}