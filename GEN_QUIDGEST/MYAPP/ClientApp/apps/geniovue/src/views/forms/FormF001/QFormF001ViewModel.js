/* eslint-disable @typescript-eslint/no-unused-vars */
import { computed, reactive, watch } from 'vue'
import _merge from 'lodash-es/merge'

import FormViewModelBase from '@/mixins/formViewModelBase.js'
import genericFunctions from '@quidgest/clientapp/utils/genericFunctions'
import modelFieldType from '@quidgest/clientapp/models/fields'

import hardcodedTexts from '@/hardcodedTexts.js'
import netAPI from '@quidgest/clientapp/network'
import qApi from '@/api/genio/quidgestFunctions.js'
import qFunctions from '@/api/genio/projectFunctions.js'
import qProjArrays from '@/api/genio/projectArrays.js'
/* eslint-enable @typescript-eslint/no-unused-vars */

/**
 * Represents a ViewModel class.
 * @extends FormViewModelBase
 */
export default class ViewModel extends FormViewModelBase
{
	/**
	 * Creates a new instance of the ViewModel.
	 * @param {object} vueContext - The Vue context
	 * @param {object} options - The options for the ViewModel
	 * @param {object} values - A ViewModel instance to copy values from
	 */
	// eslint-disable-next-line @typescript-eslint/no-unused-vars
	constructor(vueContext, options, values)
	{
		super(vueContext, options)
		// eslint-disable-next-line @typescript-eslint/no-unused-vars
		const vm = this.vueContext

		// The view model metadata
		_merge(this.modelInfo, {
			name: 'F_001',
			area: 'U_PRF',
			actions: {
				recalculateFormulas: 'RecalculateFormulas_F_001',
				updateFilesTickets: 'UpdateFilesTicketsF_001',
				setFile: 'SetFileF_001'
			}
		})

		/** The primary key. */
		this.ValCodu_prf = reactive(new modelFieldType.PrimaryKey({
			id: 'ValCodu_prf',
			originId: 'ValCodu_prf',
			area: 'U_PRF',
			field: 'CODU_PRF',
			description: '',
		}).cloneFrom(values?.ValCodu_prf))
		this.stopWatchers.push(watch(() => this.ValCodu_prf.value, (newValue, oldValue) => this.onUpdate('u_prf.codu_prf', this.ValCodu_prf, newValue, oldValue)))

		/** The remaining form fields. */
		this.ValUsername = reactive(new modelFieldType.String({
			id: 'ValUsername',
			originId: 'ValUsername',
			area: 'U_PRF',
			field: 'USERNAME',
			maxLength: 12,
			description: computed(() => this.Resources.USERNAME51409),
		}).cloneFrom(values?.ValUsername))
		this.stopWatchers.push(watch(() => this.ValUsername.value, (newValue, oldValue) => this.onUpdate('u_prf.username', this.ValUsername, newValue, oldValue)))

		this.ValBday = reactive(new modelFieldType.Date({
			id: 'ValBday',
			originId: 'ValBday',
			area: 'U_PRF',
			field: 'BDAY',
			description: computed(() => this.Resources.DATE_OF_BIRTH36542),
		}).cloneFrom(values?.ValBday))
		this.stopWatchers.push(watch(() => this.ValBday.value, (newValue, oldValue) => this.onUpdate('u_prf.bday', this.ValBday, newValue, oldValue)))

		this.ValU_img = reactive(new modelFieldType.Image({
			id: 'ValU_img',
			originId: 'ValU_img',
			area: 'U_PRF',
			field: 'U_IMG',
			description: computed(() => this.Resources.USER_IMAGE40060),
		}).cloneFrom(values?.ValU_img))
		this.stopWatchers.push(watch(() => this.ValU_img.value, (newValue, oldValue) => this.onUpdate('u_prf.u_img', this.ValU_img, newValue, oldValue)))

		this.ValU_email = reactive(new modelFieldType.String({
			id: 'ValU_email',
			originId: 'ValU_email',
			area: 'U_PRF',
			field: 'U_EMAIL',
			maxLength: 50,
			maskType: 'EM',
			description: computed(() => this.Resources.EMAIL25170),
		}).cloneFrom(values?.ValU_email))
		this.stopWatchers.push(watch(() => this.ValU_email.value, (newValue, oldValue) => this.onUpdate('u_prf.u_email', this.ValU_email, newValue, oldValue)))
	}

	/**
	 * Creates a clone of the current QFormF001ViewModel instance.
	 * @returns {QFormF001ViewModel} A new instance of QFormF001ViewModel
	 */
	clone()
	{
		return new ViewModel(this.vueContext, { callbacks: this.externalCallbacks }, this)
	}

	static QPrimaryKeyName = 'ValCodu_prf'

	get QPrimaryKey() { return this.ValCodu_prf.value }
	set QPrimaryKey(value) { this.ValCodu_prf.updateValue(value) }
}
