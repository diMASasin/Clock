﻿namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        SevenSegmentIndicator _indicator1;
        SevenSegmentIndicator _indicator2;
        SevenSegmentIndicator _indicator3;
        SevenSegmentIndicator _indicator4;
        SevenSegmentIndicator _indicator5;
        SevenSegmentIndicator _indicator6;

        public MainPage()
        {
            InitializeComponent();
            _indicator1 = new(Segment000, Segment010, Segment011, Segment020, Segment030, Segment031, Segment040);
            _indicator2 = new(Segment100, Segment110, Segment111, Segment120, Segment130, Segment131, Segment140);
            _indicator3 = new(Segment200, Segment210, Segment211, Segment220, Segment230, Segment231, Segment240);
            _indicator4 = new(Segment300, Segment310, Segment311, Segment320, Segment330, Segment331, Segment340);
            _indicator5 = new(Segment400, Segment410, Segment411, Segment420, Segment430, Segment431, Segment440);
            _indicator6 = new(Segment500, Segment510, Segment511, Segment520, Segment530, Segment531, Segment540);

            StartTimer();
        }

        private async void StartTimer()
        {
            var timer = new PeriodicTimer(TimeSpan.FromSeconds(1));

            while (await timer.WaitForNextTickAsync())
            {
                SegmentDot1.IsVisible = SegmentDot2.IsVisible = !SegmentDot1.IsVisible;
                SegmentDot3.IsVisible = SegmentDot4.IsVisible = !SegmentDot3.IsVisible;

                var now = DateTime.Now;

                _indicator1.ChangeSegmentsVisibilityByNumber( now.Hour / 10);
                _indicator2.ChangeSegmentsVisibilityByNumber(now.Hour % 10);
                _indicator3.ChangeSegmentsVisibilityByNumber(now.Minute / 10);
                _indicator4.ChangeSegmentsVisibilityByNumber(now.Minute % 10);
                _indicator5.ChangeSegmentsVisibilityByNumber(now.Second / 10);
                _indicator6.ChangeSegmentsVisibilityByNumber(now.Second % 10);
            }
        }
    }
}