﻿using System;
using System.ServiceModel.Configuration;

namespace WebHttpCors
{
    public class CorsSupportBehaviorElement : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(CorsSupportBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new CorsSupportBehavior();
        }
    }
}