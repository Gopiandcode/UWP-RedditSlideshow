﻿
using System.Collections.Generic;

namespace RedditSlideshow.Models
{

    public class Rootobject
    {
        //public string kind { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
       // public string modhash { get; set; }
        public Child[] children { get; set; }
        //public string after { get; set; }
        //public object before { get; set; }
    }

    public class Child
    {
       // public string kind { get; set; }
        public Data1 data { get; set; }
    }

    public class Data1
    {
       // public bool contest_mode { get; set; }
        //public object approved_at_utc { get; set; }
        //public object banned_by { get; set; }
       // public Media_Embed media_embed { get; set; }
       // public int? thumbnail_width { get; set; }
       // public string subreddit { get; set; }
       // public string selftext_html { get; set; }
       // public string selftext { get; set; }
       // public object likes { get; set; }
       // public object suggested_sort { get; set; }
       // public object[] user_reports { get; set; }
       // public Secure_Media secure_media { get; set; }
       // public object link_flair_text { get; set; }
       // public string id { get; set; }
       // public object banned_at_utc { get; set; }
       // public object view_count { get; set; }
       // public Secure_Media_Embed secure_media_embed { get; set; }
       // public bool clicked { get; set; }
       // public object report_reasons { get; set; }
       // public string author { get; set; }
       // public bool saved { get; set; }
       // public object[] mod_reports { get; set; }
       // public bool can_mod_post { get; set; }
       // public string name { get; set; }
       // public int score { get; set; }
       // public object approved_by { get; set; }
       // public bool over_18 { get; set; }
       // public string domain { get; set; }
        //public bool hidden { get; set; }
        public string thumbnail { get; set; }
        //public string subreddit_id { get; set; }
        //public object edited { get; set; }
        //public object link_flair_css_class { get; set; }
        //public object author_flair_css_class { get; set; }
        //public int gilded { get; set; }
        //public int downs { get; set; }
        //public bool brand_safe { get; set; }
        //public bool archived { get; set; }
        //public object removal_reason { get; set; }
        //public bool can_gild { get; set; }
        //public int? thumbnail_height { get; set; }
        //public bool hide_score { get; set; }
        //public bool spoiler { get; set; }
        public string permalink { get; set; }
        //public object num_reports { get; set; }
       // public bool locked { get; set; }
       // public bool stickied { get; set; }
       // public float created { get; set; }
        public string url { get; set; }
        //public object author_flair_text { get; set; }
        //public bool quarantine { get; set; }
        public string title { get; set; }
        //public float created_utc { get; set; }
        //public string subreddit_name_prefixed { get; set; }
        //public string distinguished { get; set; }
        //public Media media { get; set; }
        //public int num_comments { get; set; }
        //public bool is_self { get; set; }
        //public bool visited { get; set; }
        //public string subreddit_type { get; set; }
        //public bool is_video { get; set; }
        //public int ups { get; set; }
        //public Preview preview { get; set; }
        //public string post_hint { get; set; }
    }
    /*
    public class Media_Embed
    {
        public string content { get; set; }
        public int width { get; set; }
        public bool scrolling { get; set; }
        public int height { get; set; }
    }

    public class Secure_Media
    {
        public Oembed oembed { get; set; }
        public string type { get; set; }
    }

    public class Oembed
    {
        public string provider_url { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public int thumbnail_width { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string html { get; set; }
        public string version { get; set; }
        public string provider_name { get; set; }
        public string thumbnail_url { get; set; }
        public int thumbnail_height { get; set; }
    }

    public class Secure_Media_Embed
    {
        public string content { get; set; }
        public int width { get; set; }
        public bool scrolling { get; set; }
        public int height { get; set; }
    }

    public class Media
    {
        public Oembed1 oembed { get; set; }
        public string type { get; set; }
    }

    public class Oembed1
    {
        public string provider_url { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public int thumbnail_width { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string html { get; set; }
        public string version { get; set; }
        public string provider_name { get; set; }
        public string thumbnail_url { get; set; }
        public int thumbnail_height { get; set; }
    }

    public class Preview
    {
        public Image[] images { get; set; }
        public bool enabled { get; set; }
    }

    public class Image
    {
        public Source source { get; set; }
        public Resolution[] resolutions { get; set; }
        public Variants variants { get; set; }
        public string id { get; set; }
    }

    public class Source
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Variants
    {
    }

    public class Resolution
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
    */
}