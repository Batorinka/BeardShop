<template>
    <div id="home">
        <div class="album py-5 bg-light">
            <div class="container">
                <div class="row">
                    <div class="col-md-4" v-for="(product, index) in products">
                        <div class="card border-primary mb-4 shadow-sm">
                            <div class="card-header">{{product.name}}</div>
                            <div class="card-body text-primary">
                                <h5 class="card-title">{{product.price}} &#8381;</h5>
                                <div class="d-flex justify-content-between align-items-center">
                                    <div class="btn-group">
                                        <button class="btn btn-sm btn-outline-secondary" type="button" @click="showModal">Show</button>
                                        <!--<modal v-if="showModal" @close="showModal" name="Umesh">
        <p>dsfkdskf</p>
    </modal>-->
                                        <modal name="Show"></modal>
                                        <button class="btn btn-sm btn-outline-secondary" type="button" @click="onAddToCart(product)">Add to Cart</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    import axios from 'axios';
    import modal from './modal.vue'
    export default {
        name: "home-component",
        components: {modal},

        data()
        {
            return {
                products: [],
                isModalVisible: false
            }
        },

        mounted() {
            this.getProducts();
        },

        methods:
        {
            showModal() {
                this.isModalVisible = true;
            },
            closeModal() {
                this.isModalVisible = false;
            },
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
            onAddToCart(product) {
                
            }
        }
    };

</script>