import { defineAsyncComponent } from 'vue'

export default {
	install: (app) => {
		app.component('QFormAccountInfo', defineAsyncComponent(() => import('@/views/shared/AccountInfo.vue')))
		app.component('QFormFr001', defineAsyncComponent(() => import('@/views/forms/FormFr001/QFormFr001.vue')))
		app.component('QFormFr002', defineAsyncComponent(() => import('@/views/forms/FormFr002/QFormFr002.vue')))
		app.component('QFormFr003', defineAsyncComponent(() => import('@/views/forms/FormFr003/QFormFr003.vue')))
		app.component('QFormFr004', defineAsyncComponent(() => import('@/views/forms/FormFr004/QFormFr004.vue')))
		app.component('QFormFr005', defineAsyncComponent(() => import('@/views/forms/FormFr005/QFormFr005.vue')))
		app.component('QFormFr006', defineAsyncComponent(() => import('@/views/forms/FormFr006/QFormFr006.vue')))
	}
}
