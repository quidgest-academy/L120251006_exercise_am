import { propsConverter } from './routeUtils.js'

export default function getFormsRoutes()
{
	return [
		{
			path: '/:culture/:system/:module/form/FR_001/:mode/:id?',
			name: 'form-FR_001',
			props: route => propsConverter(route),
			component: () => import('@/views/forms/FormFr001/QFormFr001.vue'),
			meta: {
				routeType: 'form',
				baseArea: 'T_001',
				humanKeyFields: ['ValEmail']
			}
		},
		{
			path: '/:culture/:system/:module/form/FR_002/:mode/:id?',
			name: 'form-FR_002',
			props: route => propsConverter(route),
			component: () => import('@/views/forms/FormFr002/QFormFr002.vue'),
			meta: {
				routeType: 'form',
				baseArea: 'T_002',
				humanKeyFields: ['ValTitle', 'ValOrder']
			}
		},
		{
			path: '/:culture/:system/:module/form/FR_003/:mode/:id?',
			name: 'form-FR_003',
			props: route => propsConverter(route),
			component: () => import('@/views/forms/FormFr003/QFormFr003.vue'),
			meta: {
				routeType: 'form',
				baseArea: 'T_003',
				humanKeyFields: ['ValCountry']
			}
		},
		{
			path: '/:culture/:system/:module/form/FR_004/:mode/:id?',
			name: 'form-FR_004',
			props: route => propsConverter(route),
			component: () => import('@/views/forms/FormFr004/QFormFr004.vue'),
			meta: {
				routeType: 'form',
				baseArea: 'T_004',
				humanKeyFields: ['ValCity']
			}
		},
		{
			path: '/:culture/:system/:module/form/FR_006/:mode/:id?',
			name: 'form-FR_006',
			props: route => propsConverter(route),
			component: () => import('@/views/forms/FormFr006/QFormFr006.vue'),
			meta: {
				routeType: 'form',
				baseArea: 'T_005',
				humanKeyFields: ['ValClientname']
			}
		},
	]
}
