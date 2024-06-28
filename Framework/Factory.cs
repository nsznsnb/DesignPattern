﻿namespace Framework
{
    public abstract class Factory
    {
        public Product Create(string owner)
        {
            Product product = CreateProduct(owner);
            RegisterProduct(product);
            return product;
        }
        protected abstract Product CreateProduct(string owner);
        protected abstract void RegisterProduct(Product product);
    }
}
