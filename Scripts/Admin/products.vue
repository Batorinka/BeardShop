<template>
    <div id="products">
        <h2>Products</h2>
        <div class="table-responsive">
            <table class="table table-striped table-sm">
                <thead>
                    <tr>
                        <th>Code</th>
                        <th>Name</th>
                        <th>Price</th>
                        <th>Category</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="(product, index) in products">
                        <td>
                            <input type="text" v-if="index === currentProduct" v-model="product.code"/>
                            <span v-else>{{product.code}}</span>
                        </td>
                        <td>
                            <input type="text" v-if="index === currentProduct" v-model="product.name"/>
                            <span v-else>{{product.name}}</span>
                        </td>
                        <td>
                            <input type="number" v-if="index === currentProduct" v-model.number="product.price"/>
                            <span v-else>{{product.price}}</span>
                        </td>
                        <td>
                            <input type="text" v-if="index === currentProduct" v-model="product.category"/>
                            <span v-else>{{product.category}}</span>
                        </td>
                        <td>
                            <div class="dropdown">
                                <button class="btn btn-info" @click ="currentProduct = index">Change</button>
                                <button class="btn btn-primary" @click="onSaveProduct(product)">Save</button>
                                <button class="btn btn-danger" @click="onDeleteProduct(index, product)">Delete</button>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <input type="text" placeholder="Enter the code" v-model="newProduct.code" />
                        </td>
                        <td>
                            <input type="text" placeholder="Enter the name" v-model="newProduct.name" />
                        </td>
                        <td>
                            <input type="number" placeholder="Enter the price" v-model.number="newProduct.price" />
                        </td>
                        <td>
                            <input type="text" placeholder="Enter the category" v-model="newProduct.category" />
                        </td>
                        <td>
                            <button class="btn btn-primary" @click="onAddProduct(product)" 
                                    :disabled="!(newProduct.code && newProduct.name && newProduct.price && newProduct.category)">Add</button>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</template>

<script>
    import axios from 'axios';

    export default {
        name: "products-component",

        data()
        {
            return {
                currentProduct: false,
                products: [],
                newProduct: {code: '', name: '', price: 0, category: ''}
            }
        },

        mounted() {
            this.getProducts();
        },

        updated() {
            this.getProducts();
        },

        methods:
        {
            getProducts() {
                axios.get('/api/products')
                .then(response => {
                    this.products = response.data;
                })
                .catch(error => {
                    console.log(error)
                    alert('Error getting product')
                })
            },

            onSaveProduct(product) {
                this.currentProduct = false;
                axios.put('/api/products/' + product.id, product)
                    .then(response => { })
                    .catch(error => {
                        console.log(error)
                        alert('Error saving product')
                    });
                console.log(product);
            },

            onDeleteProduct(id, product) {
                axios.delete('/api/products/' + product.id, product.id)
                    .then(response => {
                        this.products.splice(id, 1);
                    })
                .catch(error => {
                    console.log(error)
                    alert('Error deleting product')
                })
            },

            onAddProduct() {
                axios.post('/api/products/', this.newProduct)
                    .then(response => {})
                .catch(error => {
                    console.log(error)
                    alert('Error adding product')
                })
                this.products.push(this.newProduct);
                this.newProduct = {code: '', name: '', price: 0, category: ''}
            }
        }
    };
</script>