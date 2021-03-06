using System;

namespace ALinq.SqlClient
{
    internal class SqlClientWhen
    {
        // Fields
        private SqlExpression matchExpression;
        private SqlExpression matchValue;

        // Methods
        internal SqlClientWhen(SqlExpression match, SqlExpression value)
        {
            if (value == null)
            {
                throw Error.ArgumentNull("value");
            }
            this.Match = match;
            this.Value = value;
        }

        // Properties
        internal SqlExpression Match
        {
            get
            {
                return this.matchExpression;
            }
            set
            {
                if (((this.matchExpression != null) && (value != null)) && (this.matchExpression.ClrType != value.ClrType))
                {
                    throw Error.ArgumentWrongType("value", this.matchExpression.ClrType, value.ClrType);
                }
                this.matchExpression = value;
            }
        }

        internal SqlExpression Value
        {
            get
            {
                return this.matchValue;
            }
            set
            {
                if (value == null)
                {
                    throw Error.ArgumentNull("value");
                }
                if ((this.matchValue != null) && (this.matchValue.ClrType != value.ClrType))
                {
                    throw Error.ArgumentWrongType("value", this.matchValue.ClrType, value.ClrType);
                }
                this.matchValue = value;
            }
        }
    }

 

}