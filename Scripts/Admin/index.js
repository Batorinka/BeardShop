import Vue from 'vue'
import ProductsComponent from './products.vue'
import UsersComponent from './users.vue'
import OrdersComponent from './orders.vue'

new Vue({
    el: "#appAdmin",
    components: {
        ProductsComponent,
        UsersComponent,
        OrdersComponent
    }
})