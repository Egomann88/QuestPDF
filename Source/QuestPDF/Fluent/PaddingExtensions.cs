﻿using QuestPDF.Elements;
using QuestPDF.Infrastructure;

namespace QuestPDF.Fluent
{
    public static class PaddingExtensions
    { 
        private static IContainer Padding(this IContainer element, float top = 0, float bottom = 0, float left = 0, float right = 0)
        {
            var padding = element as Padding ?? new Padding();

            padding.Top += top;
            padding.Bottom += bottom;
            padding.Left += left;
            padding.Right += right;
            
            return element.Element(padding);
        }
        
        /// <summary>
        /// <para>For positive values, adds empty space around its content.</para>
        /// <para>For negative values, pushes its content beyond the edges, increasing available space, similarly to negative HTML margins.</para>
        /// <br />
        /// <a href="https://www.questpdf.com/api-reference/padding.html">Learn more</a>
        /// </summary>
        public static IContainer Padding(this IContainer element, float value, Unit unit = Unit.Point)
        {
            value = value.ToPoints(unit);
            return element.Padding(top: value, bottom: value, left: value, right: value);
        }
        
        /// <summary>
        /// <para>For positive values, adds empty space horizontally (left and right) around its content.</para>
        /// <para>For negative values, pushes its content beyond the horizontal edges, increasing available space, similarly to negative HTML margins.</para>
        /// <br />
        /// <a href="https://www.questpdf.com/api-reference/padding.html">Learn more</a>
        /// </summary>
        public static IContainer PaddingHorizontal(this IContainer element, float value, Unit unit = Unit.Point)
        {
            value = value.ToPoints(unit);
            return element.Padding(left: value, right: value);
        }

        /// <summary>
        /// <para>For positive values, adds empty space vertically (top and bottom) around its content.</para>
        /// <para>For negative values, pushes its content beyond the vertical edges, increasing available space, similarly to negative HTML margins.</para>
        /// <br />
        /// <a href="https://www.questpdf.com/api-reference/padding.html">Learn more</a>
        /// </summary>
        public static IContainer PaddingVertical(this IContainer element, float value, Unit unit = Unit.Point)
        {
            value = value.ToPoints(unit);
            return element.Padding(top: value, bottom: value);
        }
        
        /// <summary>
        /// <para>For positive values, adds empty space above its content.</para>
        /// <para>For negative values, pushes its content beyond the top edge, increasing available space, similarly to negative HTML margins.</para>
        /// <br />
        /// <a href="https://www.questpdf.com/api-reference/padding.html">Learn more</a>
        /// </summary>
        public static IContainer PaddingTop(this IContainer element, float value, Unit unit = Unit.Point)
        {
            value = value.ToPoints(unit);
            return element.Padding(top: value);
        }
        
        /// <summary>
        /// <para>For positive values, adds empty space below its content.</para>
        /// <para>For negative values, pushes its content beyond the bottom edge, increasing available space, similarly to negative HTML margins.</para>
        /// <br />
        /// <a href="https://www.questpdf.com/api-reference/padding.html">Learn more</a>
        /// </summary>
        public static IContainer PaddingBottom(this IContainer element, float value, Unit unit = Unit.Point)
        {
            value = value.ToPoints(unit);
            return element.Padding(bottom: value);
        }
        
        /// <summary>
        /// <para>For positive values, adds empty space to the left of its content.</para>
        /// <para>For negative values, pushes its content beyond the left edge, increasing available space, similarly to negative HTML margins.</para>
        /// <br />
        /// <a href="https://www.questpdf.com/api-reference/padding.html">Learn more</a>
        /// </summary>
        public static IContainer PaddingLeft(this IContainer element, float value, Unit unit = Unit.Point)
        {
            value = value.ToPoints(unit);
            return element.Padding(left: value);
        }
        
        /// <summary>
        /// <para>For positive values, adds empty space to the right of its content.</para>
        /// <para>For negative values, pushes its content beyond the right edge, increasing available space, similarly to negative HTML margins.</para>
        /// <br />
        /// <a href="https://www.questpdf.com/api-reference/padding.html">Learn more</a>
        /// </summary>
        public static IContainer PaddingRight(this IContainer element, float value, Unit unit = Unit.Point)
        {
            value = value.ToPoints(unit);
            return element.Padding(right: value);
        }
    }
}