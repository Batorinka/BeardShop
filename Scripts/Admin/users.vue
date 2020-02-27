<template>
    <div id="users">
        <h2>Products</h2>
        <div class="table-responsive">
            <table class="table table-striped table-sm">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Email</th>
                        <th>Code</th>
                        <th>Address</th>
                        <th>Discount</th>
                        <th>Role</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="(user, index) in users">
                        <td>
                            <input type="text" v-if="index === currentUser" v-model="user.name" />
                            <span v-else>{{user.name}}</span>
                        </td>
                        <td>
                            <input type="text" v-if="index === currentUser" v-model="user.email" />
                            <span v-else>{{user.email}}</span>
                        </td>
                        <td>
                            <input type="text" v-if="index === currentUser" v-model="user.code" />
                            <span v-else>{{user.code}}</span>
                        </td>
                        <td>
                            <input type="text" v-if="index === currentUser" v-model="user.address" />
                            <span v-else>{{user.address}}</span>
                        </td>
                        <td>
                            <input type="number" v-if="index === currentUser" v-model.number="user.discount" />
                            <span v-else>{{user.discount}}</span>
                        </td>
                        <td>
                            <div class="form-group">
                                <select class="form-control" v-model.number="user.roleId">
                                    <option value="1">Admin</option>
                                    <option value="2">Customer</option>
                                </select>
                            </div>
                        </td>
                        <td>
                            <div class="dropdown">
                                <button class="btn btn-info" @click="currentUser = index">Change</button>
                                <button class="btn btn-primary" @click="onSaveUser(user)">Save</button>
                                <button class="btn btn-danger" @click="onDeleteUser(index, user)">Delete</button>
                            </div>
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
        name: "users-component",

        data() {
            return {
                currentUser: false,
                users: [],
            }
        },

        mounted() {
            this.getUsers();
        },

        created() {
            this.getUsers();
        },

        methods:
        {
            getUsers() {
                axios.get('/api/users')
                    .then(response => {
                        this.users = response.data;
                    })
                    .catch(error => {
                        console.log(error)
                        alert('Error getting user')
                    })
            },

            onSaveUser(user) {
                this.currentUser = false;
                axios.put('/api/users/' + user.id, user)
                    .then(response => { })
                    .catch(error => {
                        console.log(error)
                        alert('Error saving user')
                    });
                console.log(user);
            },

            onDeleteUser(id, user) {
                axios.delete('/api/users/' + user.id, user.id)
                    .then(response => {
                        this.users.splice(id, 1);
                    })
                    .catch(error => {
                        console.log(error)
                        alert('Error deleting user')
                    })
            }
        }
    };
</script>