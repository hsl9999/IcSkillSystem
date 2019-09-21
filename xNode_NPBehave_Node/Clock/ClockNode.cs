﻿using NPBehave;
using UnityEngine;
using XNode;
using Node = XNode.Node;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_NPBehave_Node
{
    public abstract class ClockNode:Node,INPBehaveNode
    {
        public Clock Clock { get; protected set; }

        [SerializeField,Output(typeConstraint = TypeConstraint.Inherited)]
        private ClockNode _clockNode;

        public override object GetValue(NodePort port)
        {
            _clockNode = this;
            return _clockNode;
        }
    }
}