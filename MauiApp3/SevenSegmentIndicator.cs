namespace MauiApp3
{
    public class SevenSegmentIndicator
    {
        private readonly BoxView _topSegment;
        private readonly BoxView _leftTopSegment;
        private readonly BoxView _rightTopSegment;
        private readonly BoxView _middleSegment;
        private readonly BoxView _leftBottomSegment;
        private readonly BoxView _rightBottomSegment;
        private readonly BoxView _bottomSegment;

        public SevenSegmentIndicator(BoxView topSegment, BoxView leftTopSegment, BoxView RightTopSegment, BoxView middleSegment,
            BoxView leftBottomSegment, BoxView rightBottomSegment, BoxView bottomSegment)
        {
            _topSegment = topSegment;
            _leftTopSegment = leftTopSegment;
            _rightTopSegment = RightTopSegment;
            _middleSegment = middleSegment;
            _leftBottomSegment = leftBottomSegment;
            _rightBottomSegment = rightBottomSegment;
            _bottomSegment = bottomSegment;
        }

        public void ChangeSegmentsVisibilityByNumber(int digit)
        {
            if (digit < 0 || digit > 9)
                throw new ArgumentOutOfRangeException($"SevenSegmentIndicator.ChangeSegmentsVisibilityByNumber({digit})");

            switch (digit)
            {
                default:
                    break;
                case 0:
                    _topSegment.IsVisible = true;
                    _leftTopSegment.IsVisible = true;
                    _rightTopSegment.IsVisible = true;
                    _middleSegment.IsVisible = false;
                    _leftBottomSegment.IsVisible = true;
                    _rightBottomSegment.IsVisible = true;
                    _bottomSegment.IsVisible = true;
                    break;
                case 1:
                    _topSegment.IsVisible = false;
                    _leftTopSegment.IsVisible = false;
                    _rightTopSegment.IsVisible = true;
                    _middleSegment.IsVisible = false;
                    _leftBottomSegment.IsVisible = false;
                    _rightBottomSegment.IsVisible = true;
                    _bottomSegment.IsVisible = false;
                    break;
                case 2:
                    _topSegment.IsVisible = true;
                    _leftTopSegment.IsVisible = false;
                    _rightTopSegment.IsVisible = true;
                    _middleSegment.IsVisible = true;
                    _leftBottomSegment.IsVisible = true;
                    _rightBottomSegment.IsVisible = false;
                    _bottomSegment.IsVisible = true;
                    break;
                case 3:
                    _topSegment.IsVisible = true;
                    _leftTopSegment.IsVisible = false;
                    _rightTopSegment.IsVisible = true;
                    _middleSegment.IsVisible = true;
                    _leftBottomSegment.IsVisible = false;
                    _rightBottomSegment.IsVisible = true;
                    _bottomSegment.IsVisible = true;
                    break;
                case 4:
                    _topSegment.IsVisible = false;
                    _leftTopSegment.IsVisible = true;
                    _rightTopSegment.IsVisible = true;
                    _middleSegment.IsVisible = true;
                    _leftBottomSegment.IsVisible = false;
                    _rightBottomSegment.IsVisible = true;
                    _bottomSegment.IsVisible = false;
                    break;
                case 5:
                    _topSegment.IsVisible = true;
                    _leftTopSegment.IsVisible = true;
                    _rightTopSegment.IsVisible = false;
                    _middleSegment.IsVisible = true;
                    _leftBottomSegment.IsVisible = false;
                    _rightBottomSegment.IsVisible = true;
                    _bottomSegment.IsVisible = true;
                    break;
                case 6:
                    _topSegment.IsVisible = true;
                    _leftTopSegment.IsVisible = true;
                    _rightTopSegment.IsVisible = false;
                    _middleSegment.IsVisible = true;
                    _leftBottomSegment.IsVisible = true;
                    _rightBottomSegment.IsVisible = true;
                    _bottomSegment.IsVisible = true;
                    break;
                case 7:
                    _topSegment.IsVisible = true;
                    _leftTopSegment.IsVisible = false;
                    _rightTopSegment.IsVisible = true;
                    _middleSegment.IsVisible = false;
                    _leftBottomSegment.IsVisible = false;
                    _rightBottomSegment.IsVisible = true;
                    _bottomSegment.IsVisible = false;
                    break;
                case 8:
                    _topSegment.IsVisible = true;
                    _leftTopSegment.IsVisible = true;
                    _rightTopSegment.IsVisible = true;
                    _middleSegment.IsVisible = true;
                    _leftBottomSegment.IsVisible = true;
                    _rightBottomSegment.IsVisible = true;
                    _bottomSegment.IsVisible = true;
                    break;
                case 9:
                    _topSegment.IsVisible = true;
                    _leftTopSegment.IsVisible = true;
                    _rightTopSegment.IsVisible = true;
                    _middleSegment.IsVisible = true;
                    _leftBottomSegment.IsVisible = false;
                    _rightBottomSegment.IsVisible = true;
                    _bottomSegment.IsVisible = true;
                    break;
            }
        }
    }
}