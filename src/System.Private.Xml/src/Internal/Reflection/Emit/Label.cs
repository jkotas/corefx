// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Internal.Reflection.Emit
{
    struct Label
    {
        internal int m_label;

        internal Label(int label)
        {
            m_label = label;
        }

        internal int GetLabelValue()
        {
            return m_label;
        }

        public override int GetHashCode()
        {
            return m_label;
        }

        public override bool Equals(Object obj)
        {
            if (obj is Label)
                return Equals((Label)obj);
            else
                return false;
        }

        public bool Equals(Label obj)
        {
            return obj.m_label == m_label;
        }

        public static bool operator ==(Label a, Label b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Label a, Label b)
        {
            return !(a == b);
        }
    }
}
